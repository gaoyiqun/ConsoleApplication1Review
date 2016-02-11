using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LectureReview3
{
    public class Address
    {
        public string name;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
          
        }

        public string addrDetail;

        public string AddrDetail
        {
            set
            {
                addrDetail = value;
            }
            get
            {
                return addrDetail;
            }
        }
    }
}
