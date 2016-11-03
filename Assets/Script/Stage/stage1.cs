using UnityEngine;
using System.Collections;

public class stage1 : MonoBehaviour {

    public GameObject _R_Block1;        //일반직사 1
    public GameObject _R_Block2;        //일반직사 2

    public int Block_num = 4;

    GameObject parent;


	
    // Use this for initialization
    void Start()
    {
        parent = GameObject.Find("Block");

        Debug.Log(0);
        GameObject Obj = (GameObject)Instantiate(_R_Block2, new Vector3(0 + (115f / 2f + 10f) / 100f, 0 + (64f / 2f + 10f) / 100f, 0), Quaternion.identity);
        Obj.transform.parent = parent.transform;
        GameObject Obj1 = (GameObject)Instantiate(_R_Block2, new Vector3(0 + (115f / 2f + 10f) / 100f, 0 - (64f / 2f + 10f) / 100f, 0), Quaternion.identity);
        Obj1.transform.parent = parent.transform;
        GameObject Obj2 = (GameObject)Instantiate(_R_Block2, new Vector3(0 - (115f / 2f + 10f) / 100f, 0 + (64f / 2f + 10f) / 100f, 0), Quaternion.identity);
        Obj2.transform.parent = parent.transform;
        GameObject Obj3 = (GameObject)Instantiate(_R_Block2, new Vector3(0 - (115f / 2f + 10f) / 100f, 0 - (64f / 2f + 10f) / 100f, 0), Quaternion.identity);
        Obj3.transform.parent = parent.transform;

    }
}
