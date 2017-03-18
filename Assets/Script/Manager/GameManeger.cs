using UnityEngine;
using System.Collections;

public class GameManeger : MonoBehaviour
{
    public Circle cir;

    bool beginStart = false;

    public GameObject parent;

    public GameObject[] _Stage;

    Vector2 touchPos;

    public string temp;
    public int GameStage;

    int Block_type;


    Vector2 beginpos;
    public GameObject scrollObj;
    bool scrollMove = false;
    int coun = 0;
    public GameObject[] butt;

    public GameObject ball;
    public GameObject upDown;


    void Start()
    {
        if (Singleton.getInstance.isReplay)
        {
            Singleton.getInstance.isReplay = false;
            stageSet(Singleton.getInstance.stageNum);
            gameStart();
        }
    }

    public void down()
    {
        if (coun < 3)
        {
            coun++;
            butt[0].SetActive(true);
            butt[1].SetActive(true);
            if (coun == 3)
            {
                butt[0].SetActive(false);
            }
        }
        //scrollObj.transform.localPosition = (new Vector2(0, 360 * coun));
    }

    public void up()
    {
        if (coun > 0)
        {
            coun--;
            butt[0].SetActive(true);
            butt[1].SetActive(true);
            if (coun == 0)
            {
                butt[1].SetActive(false);
            }
        }

        //scrollObj.transform.position = (new Vector2(0, 360 * coun));
        // 완성
    }

    void Update()
    {
        scrollObj.transform.localPosition = Vector2.MoveTowards(scrollObj.transform.localPosition, new Vector2(0, 360 * coun), 70);
    }

    public void stageSet(int i )
    {
        GameStage = i;
        Singleton.getInstance.stageNum = i;
    }

    public void gameStart()
    {
        upDown.SetActive(false);
        scrollObj.SetActive(false);
        cir.start = true;
        createMap();
    }

    public void createMap ()
    {
        ball.SetActive(true);
        GameObject Stage = (GameObject)Instantiate(_Stage[GameStage], new Vector3(0, 0, 0), Quaternion.identity);
        Stage.transform.parent = parent.transform;
    }
}