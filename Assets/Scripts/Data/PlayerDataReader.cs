using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class PlayerDataReader : MonoBehaviour
{
    public List<TextAsset> textFileList = new List<TextAsset>();

    Player index = new Player();
    public List<Player> playerList = new List<Player>();
    public Dictionary<int, Player> playerMap = new Dictionary<int, Player>();

    void Start()
    {
        foreach(TextAsset jsonText in textFileList)
        {
            string filePath = Application.dataPath + "/Files/" + jsonText.name + ".json";
            Debug.Log(filePath);
            string[] textArr = File.ReadAllLines(filePath);
            foreach(string str in textArr)
            {
                StringBuilder sb = new StringBuilder(str);

                if (str.Contains("season"))
                {
                    sb.Replace("\"season\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    index.season = sb.ToString();
                }
                if (str.Contains("\"name\""))
                {
                    sb.Replace("    \"name\": ", "");
                    sb.Replace("\"", "");
                    sb.Replace(",", "");
                    index.fullName = sb.ToString();
                }
                if (str.Contains("country"))
                {
                    sb.Replace("\"country\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    index.country = sb.ToString();
                }
                if (str.Contains("position"))
                {
                    sb.Replace("\"main_position\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    index.mainPos = sb.ToString();
                }
                if (str.Contains("salary"))
                {
                    sb.Replace("\"salary\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    int.TryParse(sb.ToString(), out index.salary);
                }

                if (str.Contains("image_name"))
                {
                    sb.Replace("\"image_name\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    index.imgName = sb.ToString();
                }
                if (str.Contains("\"id\""))
                {
                    sb.Replace("\"id\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    int.TryParse(sb.ToString(), out index.id);
                    playerList.Add(index);
                    index = new Player();
                }
               
                if (str.Contains("\"1\""))
                {
                    int temp = 0;
                    sb.Replace("\"1\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    int.TryParse(sb.ToString(), out temp);
                    index.statList.Add(temp);
                }
                if (str.Contains("\"2\""))
                {
                    int temp = 0;
                    sb.Replace("\"2\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    int.TryParse(sb.ToString(), out temp);
                    index.statList.Add(temp);
                }
                if (str.Contains("\"3\""))
                {
                    int temp = 0;
                    sb.Replace("\"3\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    int.TryParse(sb.ToString(), out temp);
                    index.statList.Add(temp);
                }
                if (str.Contains("\"4\""))
                {
                    int temp = 0;
                    sb.Replace("\"4\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    int.TryParse(sb.ToString(), out temp);
                    index.statList.Add(temp);
                }
                if (str.Contains("\"5\""))
                {
                    int temp = 0;
                    sb.Replace("\"5\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    int.TryParse(sb.ToString(), out temp);
                    index.statList.Add(temp);
                }
                if (str.Contains("\"6\""))
                {
                    int temp = 0;
                    sb.Replace("\"6\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    int.TryParse(sb.ToString(), out temp);
                    index.statList.Add(temp);
                }
                if (str.Contains("\"7\""))
                {
                    int temp = 0;
                    sb.Replace("\"7\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    int.TryParse(sb.ToString(), out temp);
                    index.statList.Add(temp);
                }
                if (str.Contains("\"8\""))
                {
                    int temp = 0;
                    sb.Replace("\"8\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    int.TryParse(sb.ToString(), out temp);
                    index.statList.Add(temp);
                }
                if (str.Contains("\"9\""))
                {
                    int temp = 0;
                    sb.Replace("\"9\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    int.TryParse(sb.ToString(), out temp);
                    index.statList.Add(temp);
                }
                if (str.Contains("\"10\""))
                {
                    int temp = 0;
                    sb.Replace("\"10\":", "");
                    sb.Replace("\"", "");
                    sb.Replace(" ", "");
                    sb.Replace(",", "");
                    int.TryParse(sb.ToString(), out temp);
                    index.statList.Add(temp);
                }
            }
        }

        foreach(Player p in playerList)
        {
            Debug.Log("Name:" + p.fullName + "\nCountry:" + p.country + "\nPos:" + p.mainPos);
            foreach(int stat in p.statList) { Debug.Log(stat); }
        }
        
    }

    
}
