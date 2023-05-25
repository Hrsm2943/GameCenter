using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float MvNum = 1.0f;
    public float rotateSpeed = 2.0f;            //‰ñ“]‚Ì‘¬‚³
    Vector3 target = new Vector3(0f, 0.01f, 0f);
    public bool Move_Enable = true;
    //[SerualizeField] Sprite IMG;

    // «‘Œ^‚Ì•Ï”‚ğg‚Á‚Ä‚Ü‚·B
    Dictionary<string, bool> move = new Dictionary<string, bool>
    {
        {"up", false },
        {"down", false },
        {"right", false },
        {"left", false },
    };

    // Update is called once per frame
    void Update()
    {
        move["up"] = Input.GetKey(KeyCode.W);
        move["down"] = Input.GetKey(KeyCode.S);
        move["right"] = Input.GetKey(KeyCode.D);
        move["left"] = Input.GetKey(KeyCode.A);

    }

    void FixedUpdate()
        {
            //private Vector3 position;

            if (Move_Enable == true)
            {
                if (move["up"])
                {
                    transform.Translate(0f, 0f, MvNum);
                }
                if (move["down"])
                {
                    transform.Translate(0f, 0f, -MvNum);
                }
                if (move["right"])
                {
                    transform.Translate(MvNum, 0f, 0f);
                }
                if (move["left"])
                {
                    transform.Translate(-MvNum, 0f, 0f);
                }
                rotateCamera();
            }
        }

    private void rotateCamera()
    {
        //Vector3‚ÅX,Y•ûŒü‚Ì‰ñ“]‚Ì“x‡‚¢‚ğ’è‹`
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed, Input.GetAxis("Mouse Y") * rotateSpeed, 0);

        //transform.RotateAround()‚ğ‚µ‚æ‚¤‚µ‚ÄƒƒCƒ“ƒJƒƒ‰‚ğ‰ñ“]‚³‚¹‚é
        transform.RotateAround(transform.position, Vector3.up, angle.x);
    }
}
