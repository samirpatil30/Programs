using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using Experimental.System.Messaging;

namespace CommanLayer.MSMQ
{
   public class MsmqTokenSender
    {
        public void SendMsmqToken(string Email, string Token)
        {

            MessageQueue MyQueue;

            if (MessageQueue.Exists(@".\Private$\MyQueue"))
            {
                MyQueue = new MessageQueue(@".\Private$\MyQueue");
            }
            else
            {
                MyQueue = MessageQueue.Create(@".\Private$\MyQueue");
            }

            try
            {
                MyQueue.Send(Email, Token);
            }
            catch (MessageQueueException mqe)
            {
                Console.Write(mqe.Message);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                MyQueue.Close();
            }

            Console.WriteLine("message Sent");
        }
    }
}
