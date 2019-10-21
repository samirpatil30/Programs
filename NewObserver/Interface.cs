using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.NewObserver
{
  public interface Interface
    {
        public void AddItem();
        public void AddUser();
        public void Notify();
    }


    public class SubjetOne : Interface
    {
       public List<string> listOfUser = new List<string>();
       public List<string> itemList = new List<string>();

        public void AddItem()
        {
            itemList.Add("Bat");
            itemList.Add("Ball");
            itemList.Add("stumps");

        }

        public void AddUser()
        {
            listOfUser.Add("samir");
            listOfUser.Add("Satish");
        }

        public void Notify()
        {

        }
    }
}
