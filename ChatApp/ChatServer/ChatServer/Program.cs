using System;
using System.Threading;
using System.Net.Sockets;
using System.Collections;
using System.Text;

namespace ChatServer
{
    class Program
    {
        public static Hashtable clientList = new Hashtable();

        static void Main(string[] args)
        {
            TcpListener serverSocket = new TcpListener(8888);
            TcpClient clientSocket = default(TcpClient);

            serverSocket.Start();
            Console.WriteLine("Server Started...");
            

            while (true)
            {
                clientSocket = serverSocket.AcceptTcpClient();
                byte[] bytesFrom = new byte[10025];
                string dataFromClient = null;
                
                NetworkStream networkStream = clientSocket.GetStream();

                networkStream.Read(bytesFrom, 0, 10000);
                dataFromClient = Encoding.ASCII.GetString(bytesFrom);
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                clientList.Add(dataFromClient, clientSocket);
                broadcast(dataFromClient + " Joined the Chat", dataFromClient, false);
                Console.WriteLine(dataFromClient + " Joined the Chat Room");

                handleClient client = new handleClient();
                client.startClient(clientSocket, dataFromClient, clientList);
            }
        }

        public static void broadcast(string msg, string uName, bool flag)
        {
            
            foreach (DictionaryEntry Item in clientList)
            {
                TcpClient broadcastSocket;
                broadcastSocket = (TcpClient)Item.Value;
                NetworkStream broadcastStream = broadcastSocket.GetStream();
                byte[] broadcastBytes = null;

                if (flag == true)
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(uName + " : " + msg);
                }
                else
                {
                    broadcastBytes = Encoding.ASCII.GetBytes(msg);
                }
                broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                broadcastStream.Flush();
            }
        }

    }

    public class handleClient
    {
        TcpClient cSocket;
        string cNumber;
        Hashtable cList;

        public void startClient(TcpClient inClientSocket, string number, Hashtable list)
        {
                this.cSocket = inClientSocket;
                this.cList = list;
                this.cNumber = number;
                Thread clientThread = new Thread(doChat);
                clientThread.Start();
        }

        private void doChat()
        {
            int requestCount = 0;
            byte[] bytesFrom = new byte[10025];
            Byte[] sendBytes = null;
            string dataFromClient = null;
            string serverResponse = null;
            string rCount = null;
            requestCount = 0;
            while (cSocket.Connected == true)
            {
                    requestCount += 1;
                    NetworkStream networkStream = cSocket.GetStream();

                    if (networkStream.Read(bytesFrom, 0, 10000) != 0)
                    {
                        dataFromClient = Encoding.ASCII.GetString(bytesFrom);
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                        Console.WriteLine("From client - " + cNumber + " : " + dataFromClient);
                        rCount = Convert.ToString(requestCount);
                        Program.broadcast(dataFromClient, cNumber, true);
                    }

                    else
                    {
                        Console.WriteLine(cNumber + " Left the Chat Room");
                        cList.Remove(cNumber);
                        cSocket.Close();
                    }
                
            }
        }
    }
}
