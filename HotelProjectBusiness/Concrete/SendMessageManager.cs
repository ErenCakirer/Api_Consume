using HotelProjectBusiness.Abstract;
using HotelProjectDataAccess.Abstract;
using HotelProjectDataAccess.EF;
using HotelProjectEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectBusiness.Concrete
{
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public void Delete(SendMessage t)
        {_sendMessageDal.Delete(t); }
        

        public SendMessage GetByID(int id)
        {
         return _sendMessageDal.GetByID(id);
        }

        public void Insert(SendMessage t)
        {
            _sendMessageDal.Insert(t);
        }

        public int SendMessageCount()
        {
      return _sendMessageDal.SendMessageCount();
        }

        public List<SendMessage> TGetList()
        {
           return _sendMessageDal.GetList();
        }

        public void Update(SendMessage t)
        {
            _sendMessageDal.Update(t);
        }
    }
}
