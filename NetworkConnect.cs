using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace ATP {
    static class NetworkConnect {
        const string SERVER_IP = "192.168.1.107";
        const int SERVER_PORT = 7332;
        public static GameRecord[] UpdateScore(GameRecord gameRecord) {
            Socket clientSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            IPAddress iPAddress = IPAddress.Parse(SERVER_IP.Trim());
            IPEndPoint ip = new IPEndPoint(iPAddress, SERVER_PORT);
            try { 
                clientSocket.Connect(ip);
                string tmp = JsonSerializer.Serialize<GameRecord>(gameRecord);
                clientSocket.Send(Encoding.ASCII.GetBytes(tmp));
                byte[] buffer = new byte[2048];
                int len=
                clientSocket.Receive(buffer);
                return JsonSerializer.Deserialize<GameRecord[]>(Encoding.ASCII.GetString(buffer,0,len));
            } catch(Exception e) {
                throw e;
            }
        }
        public static GameRecord[] GetGameRecords() {
            return UpdateScore(new GameRecord(-1, "test"));
        }
    }
    [Serializable]
    public class GameRecord {
        public GameRecord() { }
        public GameRecord(int score, string name) {
            this.score = score;
            this.name = name;
        }
        public int score { get; set; }
        public string name { get; set; }
    }
    static class GameRecordList {
        public static GameRecord[] gameRecords = null;
    }
}
