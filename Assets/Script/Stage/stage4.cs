using UnityEngine;
using System.Collections;

public class stage4 : MonoBehaviour {

    public GameObject _R_Block1;        //일반직사 1
    public GameObject _R_Block2;        //일반직사 2
    
    public GameObject B_R_Block1;       //폭발직사 1
    public GameObject B_R_Block2;       //폭발직사 2
    public GameObject B_R_Block3;       //폭발직사 3

    public int Block_num = 10;

    GameObject parent;

    // Use this for initialization
    void Start()
    {
        parent = GameObject.Find("Block");
        GameObject Obj = (GameObject)Instantiate(_R_Block2, new Vector3(0, 0 - (64f/2 + 5f) / 100f, 0), Quaternion.identity);
        Obj.transform.parent = parent.transform;
        GameObject Obj1 = (GameObject)Instantiate(_R_Block2, new Vector3(0 + (115f + 10f) / 100f, 0 - (64f / 2 + 5f) / 100f, 0), Quaternion.identity);
        Obj1.transform.parent = parent.transform;
        GameObject Obj2 = (GameObject)Instantiate(_R_Block2, new Vector3(0 - (115f + 10f) / 100f, 0 - (64f/2 + 5f) / 100f, 0), Quaternion.identity);
        Obj2.transform.parent = parent.transform;
        GameObject Obj3 = (GameObject)Instantiate(_R_Block2, new Vector3(0, 0 + (64f/2 + 5f)/100f, 0), Quaternion.identity);
        Obj3.transform.parent = parent.transform;
        GameObject Obj4 = (GameObject)Instantiate(_R_Block2, new Vector3(0 + (115f + 10f) / 100f, 0 + (64f/2 + 5f)/100f, 0), Quaternion.identity);
        Obj4.transform.parent = parent.transform;
        GameObject Obj5 = (GameObject)Instantiate(_R_Block2, new Vector3(0 - (115f + 10f) / 100f, 0 + (64f/2 + 5f)/100f, 0), Quaternion.identity);
        Obj5.transform.parent = parent.transform;

        GameObject Obj6 = (GameObject)Instantiate(B_R_Block3, new Vector3(0 + (115f / 2 + 10f) / 100f, 0 - (64f * 1.5f + 15f) / 100f, 0), Quaternion.identity);
        Obj6.transform.parent = parent.transform;
        GameObject Obj7 = (GameObject)Instantiate(_R_Block2, new Vector3(0 + (115f / 2 + 10f) / 100f, 0 + (64f * 1.5f + 15f) / 100f, 0), Quaternion.identity);
        Obj7.transform.parent = parent.transform;
        GameObject Obj8 = (GameObject)Instantiate(_R_Block2, new Vector3(0 - (115f / 2 + 10f) / 100f, 0 - (64f * 1.5f + 15f) / 100f, 0), Quaternion.identity);
        Obj8.transform.parent = parent.transform;
        GameObject Obj9 = (GameObject)Instantiate(B_R_Block3, new Vector3(0 - (115f / 2 + 10f) / 100f, 0 + (64f * 1.5f + 15f) / 100f, 0), Quaternion.identity);
        Obj9.transform.parent = parent.transform;
    }
	
}
