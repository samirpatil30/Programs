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
            //// Create the instance of MessageQueue
            MessageQueue MyQueue;

            //// Check if the Queue is exist or not, if not exist create a new queue
            if (MessageQueue.Exists(@".\Private$\MyQueue"))
            {
                MyQueue = new MessageQueue(@".\Private$\MyQueue");
            }
            else
            {
                //// Create the new Instance of queue
                MyQueue = MessageQueue.Create(@".\Private$\MyQueue");
            }

            try
            {
                //// Here send() send the data into queue 
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

            
           // Console.WriteLine("message Sent");
        }
    }
}
