using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MinimapCameraFollow : MonoBehaviour
{
    [SerializeField] private MinimapSettings _settings;
    [SerializeField] private float cameraHeight;
    public GameObject Player;
    public GameObject MapPanel;
    bool pos1, pos2;
    int pos;

    private void Awake()
    {
        _settings = GetComponentInParent<MinimapSettings>();
        Player = GameObject.Find("PlayerCapsule");  //PlayerArmature(Clone)
        cameraHeight = transform.position.y;
        pos2 = pos1= false;
    }

    void Update()
    {
        if(Player != null)
        {
            Vector3 targetPosition = _settings.targetToFollow.transform.position;

            transform.position = new Vector3(targetPosition.x, targetPosition.y + cameraHeight, targetPosition.z);

        }





        /*if(_settings.rotateWithTarget)
        {
            Quaternion targetRotation = _settings.targetToFollow.transform.rotation;

            transform.rotation = Quaternion.Euler(90,targetRotation.eulerAngles.y,0);
        }*/
    }
    private void FixedUpdate()
    {
        switch (pos)
        {
            case 1:
                Player.transform.position = new Vector3(15.5f, 0, 0);
                Debug.Log("Pos 1 Executed");
                pos = 0;
                break;
            case 2:
                Player.transform.position = new Vector3(0, 0, 25.5f);
                pos = 0;
                break;
            case 3:
                Player.transform.position = new Vector3(-10.0f, 0, 17.0f);
                pos = 0;
                break;

            case 4:
                Player.transform.position = new Vector3(-8.5f, 2.1f, 26.0f);
                pos = 0;
                break;

            case 5:
                Player.transform.position = new Vector3(4.7f, 6.5f, 9.35f);
                pos = 0;
                break;
            case 6:
                Player.transform.position = new Vector3(-7.36f, 3.0f, 1.37f);
                pos = 0;
                break;
        }
        
       /* if (pos2)
        {
            Player.transform.position = new Vector3(15.5f, 0, 0);
            pos2 = false;
        }
        if (pos1)
        {
            Player.transform.position = new Vector3(0, 0, 25.5f);
            pos1 = false;
        }*/
    }

    public void OpenMap()
    {
        MapPanel.SetActive(true);
    }

    public void CloseMap()
    {
        if(MapPanel.activeInHierarchy)
        {
            MapPanel.SetActive(false);
        }
    }

    public void Location1()
    {
        pos = 1;
       //pos2 = true;
        //Player.transform.position = new Vector3(15.5f, 0, 0);
        // Player.transform.position = new Vector3(Player.transform.position.x + 15.5f, Player.transform.position.y, Player.transform.position.z);
        MapPanel.SetActive(false);
    }
    public void Location2()
    {
        //pos1 = true;
        pos = 2;
        //Player.transform.position = new Vector3(0, 0, 25.5f);
        //Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z + 25.5f);
        MapPanel.SetActive(false);
    }
    public void Location3()
    {
        pos = 3;
        //Player.transform.position = new Vector3(-10.0f, 0, 17.0f);
        // Player.transform.position = new Vector3(Player.transform.position.x - 10.0f, Player.transform.position.y, Player.transform.position.z + 17f);
        MapPanel.SetActive(false);
    }
    public void Location4()
    {
        pos = 4;
        //Player.transform.position = new Vector3(-8.5f, 2.1f, 26.0f);
        //Player.transform.position = new Vector3(Player.transform.position.x - 8.5f, Player.transform.position.y + 2.1f, Player.transform.position.z + 26.0f);
        MapPanel.SetActive(false);
    }
    public void Location5()
    {
        pos = 5;    
        //Player.transform.position = new Vector3(4.7f, 6.5f, 9.35f);
        //Player.transform.position = new Vector3(Player.transform.position.x + 4.7f, Player.transform.position.y + 6.5f, Player.transform.position.z + 9.35f);
        MapPanel.SetActive(false);
    }
    public void Location6()
    {
        pos = 6;
        //Player.transform.position = new Vector3(-7.36f, 3.0f, 1.37f);
        //Player.transform.position = new Vector3(Player.transform.position.x - 7.36f, Player.transform.position.y + 3.0f, Player.transform.position.z + 1.37f);
        MapPanel.SetActive(false);
    }
}
