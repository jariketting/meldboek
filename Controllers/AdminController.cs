﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using IdentityModel;
using meldboek.Models;
using Microsoft.AspNetCore.Mvc;
using Neo4j.Driver;
using Newtonsoft.Json;
using Remotion.Linq.Clauses.ResultOperators;

namespace meldboek.Controllers
{
    public class AdminController : Controller
    {
        public IDriver Driver { get; set; }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateAccount()
        {
            return View();
        }

        public IActionResult LogIn(string email, string password)
        {

            {
                if (email == "admin" && password == "admin")
                {
                    Response.Redirect("LogIn");
                }
            }



            return View();

        }
        public IActionResult CreateGroups(string Groepnaam, string ManagerID)
        {
            if (Groepnaam != null)
            {
                int groupId = GetMaxGroupId();
                Group g = new Group(groupId, Groepnaam);

                var r = ConnectDb("CREATE (g:Group {GroupId: " + g.GroupId + ", GroupName: '" + g.GroupName + "' }) RETURN g");

                r.Wait();
                //dit is om het de Neo4J ID te pakken
                // var GroupLong = r.Result[0].Id; 
                // int GroupId = unchecked((int)GroupLong);


                var r2 = ConnectDb("MATCH (p:Person),(g:Group) WHERE p.PersonId = " + ManagerID + " AND g.GroupId = " + groupId + " CREATE(p) -[r: IsOwner]->(g) RETURN p, g");
                r2.Wait();

            }

            //var a =  (ClaimsPrincipal)Thread.CurrentPrincipal;
            //  // var naaam = Microsoft.AspNet.Identity.Claims.Where(c => c.Type == ClaimTypes.Name);
            //  string UserId;
            //  foreach (var v in a.Identities)
            //  {
            //      UserId = v.Name;
            //  }
            //var USerID = Thread.CurrentPrincipal?.Identity.Name;

            //var username = User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;

            Person p = ClaimsController.Instance.GetClaim();

            return View();


         

        }

        public int GetMaxGroupId()
        {
            // GetMaxPostId gets the Person with the highest id from the database and returns the id.

            List<INode> postNodes = new List<INode>();
            var getPosts = ConnectDb("MATCH(p:Group) RETURN p ORDER BY toInteger(p.GroupId) DESC LIMIT 1");
            var Group = new Group();

            postNodes = getPosts.Result;
            foreach (var record in postNodes)
            {
                var nodeprops = JsonConvert.SerializeObject(record.As<INode>().Properties);
                Group = (JsonConvert.DeserializeObject<Group>(nodeprops));
            }

            return Group.GroupId + 1;
        }

        public async Task<List<INode>> ConnectDb(string query)
        {
            Driver = CreateDriverWithBasicAuth("bolt://localhost:7687", "neo4j", "1234");
            List<INode> res = new List<INode>();
            IAsyncSession session = Driver.AsyncSession(o => o.WithDatabase("neo4j"));

            try
            {
                res = await session.ReadTransactionAsync(async tx =>
                {
                    var results = new List<INode>();
                    var reader = await tx.RunAsync(query);

                    while (await reader.FetchAsync())
                    {
                        results.Add(reader.Current[0].As<INode>());

                    }

                    return results;
                });


            }

            finally
            {
                await session.CloseAsync();

            }
            return res;

        }
        public IDriver CreateDriverWithBasicAuth(string uri, string Person, string password)
        {
            return GraphDatabase.Driver(new Uri(uri), AuthTokens.Basic(Person, password));
        }

    }
}