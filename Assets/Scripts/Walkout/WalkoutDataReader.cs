using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class WalkoutDataReader : MonoBehaviour
{
    public static WalkoutDataReader instance;

    [SerializeField]
    List<Sprite> flagList;
    [SerializeField]
    List<Sprite> profileImgList;

    [SerializeField]
    SpriteRenderer flagRender;
    [SerializeField]
    SpriteRenderer profileImgRender;
   

    void Start()
    {
        if (!instance) instance = this;
        else Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("R");
            RandomValue();
        }
    }

    public void GetPlayerCountryFlag(Player p)
    {
        foreach(Sprite flag in flagList)
        {
            if (flag.name.Equals(p.country))
            {
                flagRender.sprite = flag;
                break;
            }
        }
    }
    public void GetPlayerProfileImage(Player p)
    {
        foreach (Sprite img in profileImgList)
        {
            if (p.imgName.Equals(img.name))
            {
                profileImgRender.sprite = img;
                break;
            }
        }
    }

    public void RandomValue() 
    {
        if (PlayerDataReader.instance.playerList.Count > 0)
        {
            int index = Random.Range(0, PlayerDataReader.instance.playerList.Count);
            Player p = PlayerDataReader.instance.playerList[index];
            GetPlayerCountryFlag(p);
            GetPlayerProfileImage(p);
            Debug.Log(p.fullName + " " + p.country);
        }
    }
}
