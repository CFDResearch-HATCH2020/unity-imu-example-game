using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if PLATFORM_ANDROID
using UnityEngine.Android;
#endif

public class PlayerControls : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundCheck;
    public Transform startPosition;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;

    private float pitch, roll, yaw;
    private int batteryCharge;
    //Text myText;

    private AndroidJavaObject javaClass;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello from C#");
        
         //myText= GetComponent<Text>();

#if PLATFORM_ANDROID
            if (!Permission.HasUserAuthorizedPermission(Permission.CoarseLocation))
            {
                Permission.RequestUserPermission(Permission.CoarseLocation);  //Required for bluetooth connection
                
            }
#endif
        rb = GetComponent<Rigidbody2D>();
        AndroidJavaClass uPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject uAct = uPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        object[] para = new object[2];
        para[0] = uAct;
        para[1] = "FC:5B:BA:D6:B4:BB";
        javaClass = new AndroidJavaObject("com.example.metawearandroidplugin.MetaWearWrapper", para);
    }

    void changePitchValue(string p)
    {
        print("Hello from C#: " + p);
        pitch = float.Parse(p);
        
        rb.position = new Vector2(0, pitch);
        
    }

    void changeRollValue(string r)
    {
        roll = float.Parse(r);
    }
    void changeYawValue(string y)
    {
        yaw = float.Parse(y);
    }
    void changeBatteryChargeValue(string c)
    {
        batteryCharge = int.Parse(c);
    }



    // Update is called once per frame
    void Update()
    {
        //javaClass.Call("getBattery"); //call to update battery data
        rb.velocity = new Vector2(3, rb.velocity.y);
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        if (Input.GetMouseButtonDown(0) && onGround)
        {

            rb.velocity = new Vector2(rb.velocity.x,0.5f);

        }
    }
}
