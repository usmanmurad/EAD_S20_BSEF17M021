using Entities;
using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPIs.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        
        [HttpPost]
        public List<Folders> GetFolders(int ID)
        {
            List<Folders> l1 = new List<Folders>();
            l1 = BAL.BAL.GetFolders(ID);
            //Session["FolderID"] = ID;
            return l1;
        }
        [HttpPost]
        public int CreateFolder(string Name,int ID)
        {
            //int ID = (int)Session["FolderID"];
            int id1 = BAL.BAL.CreateFolder(ID, Name);
            return id1;
        }
        public int GetParentFolder(int ID)
        {
            //int Child = (int)Session["FolderID"];
            int Parent = BAL.BAL.ReturnParent(ID);
            return Parent;
        }
        
    }
}
