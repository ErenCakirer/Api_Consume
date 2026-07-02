using HotelProjectDataAccess.Abstract;
using HotelProjectDataAccess.Concrete;
using HotelProjectDataAccess.Repositories;
using HotelProjectEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccess.EF
{
 public class EFSendMessageDal:GenericRepo<SendMessage>,ISendMessageDal
    {
        public EFSendMessageDal(Context context):base(context) { }

        public int SendMessageCount()
        {
           var context= new Context();
            return context.SendMessages.Count();
        }
    }
}
