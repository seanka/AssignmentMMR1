using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject[] ObjectNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ChangeObject() {
        if(ObjectNum[0].activeSelf) {
            ObjectNum[0].SetActive(false);
            ObjectNum[1].SetActive(false);
            ObjectNum[2].SetActive(true);
            print("Object 0 was on, Changing into Object 2");
        } else if(ObjectNum[1].activeSelf) {
            ObjectNum[0].SetActive(true);
            ObjectNum[1].SetActive(false);
            ObjectNum[2].SetActive(false);
            print("Object 1 was on, Changing into Object 0");
        } else if(ObjectNum[2].activeSelf) {
            ObjectNum[0].SetActive(false);
            ObjectNum[1].SetActive(true);
            ObjectNum[2].SetActive(false);
            print("Object 2 was on, Changing into Object 1");
        }
    }
}
