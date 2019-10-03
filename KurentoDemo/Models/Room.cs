
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurentoDemo.Models
{
    public class Room
    {
        public string RoomID { set; get; }
        public DateTime CreateDate { set; get; }
        public int CreateUserID { set; get; }
        public string CreateUserName { set; get; }
        public string Path { set; get; }
        /// <summary>
        /// 车牌
        /// </summary>
        public string CarNo { set; get; }

       
    }

    
}
