using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{

    public Transform transform;
    float horizontalInput;
    float verticalInput;
    public float scale;
    public float maxAngle;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();
    }

    private void MyInput()
    {
        float directionX = 0;
        float directionZ = 0;
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

         //Debug.Log(horizontalInput);
        // Debug.Log(verticalInput);
        if(horizontalInput != 0 ){
          directionZ = addInclineHorizontal(horizontalInput);
          //Debug.Log(direction);
        }
        else{
          directionZ = decendNormalHorizontal(horizontalInput);
        }

        if(verticalInput != 0 ){
          directionX = addInclineVertical(verticalInput);
          //Debug.Log(direction);
        }
        else{
          directionX = decendNormalVertical(verticalInput);
        }
        transform.eulerAngles = new Vector3(
                  directionX,
                  transform.eulerAngles.y,
                  directionZ
                );
    }


    private float decendNormalVertical(float verticalInput){
      if (verticalInput == 0){
        if ((transform.eulerAngles.x < (maxAngle+5)) && (transform.eulerAngles.x >= (2*scale)) ){
          //Debug.Log(49);
          return transform.eulerAngles.x -(1*scale);
        }
        else if((transform.eulerAngles.x > 355 - maxAngle)&&(transform.eulerAngles.x<=360-(2*scale))){
          //Debug.Log(57);
          return transform.eulerAngles.x +(1*scale);
        }
      }
      return transform.eulerAngles.x;
    }
    private float addInclineVertical(float verticalInput){


      //if ((horizontalInput == -1)&&((transform.eulerAngles.z < 360)||(transform.eulerAngles.z > 360 - maxAngle)||((transform.eulerAngles.z < 360)&&(transform.eulerAngles.z > maxAngle)))){
      if ((verticalInput == 1)&&(((transform.eulerAngles.x > maxAngle)||(transform.eulerAngles.x < 360 - maxAngle))&&(!((transform.eulerAngles.x > maxAngle)&&(transform.eulerAngles.x < 360 - maxAngle)))))
      {
        return transform.eulerAngles.x + (verticalInput*scale);

      }
      else if ((verticalInput == -1)&&((transform.eulerAngles.x < maxAngle)||(transform.eulerAngles.x > 360 - maxAngle))){
      //else if ((horizontalInput == 1)&&((transform.eulerAngles.z < maxAngle)||(transform.eulerAngles.z > 360 - maxAngle))){
        return transform.eulerAngles.x + (verticalInput*scale);
      }
      //decendNormalHorizontal(horizontalInput);
      return transform.eulerAngles.x;

    }


/*=============================Horizontal=============================*/

    private float decendNormalHorizontal(float horizontalInput){
      if (horizontalInput == 0){
        if ((transform.eulerAngles.z < (maxAngle+5)) && (transform.eulerAngles.z >= (2*scale)) ){
          //Debug.Log(49);
          return transform.eulerAngles.z -(1*scale);
        }
        else if((transform.eulerAngles.z > 355 - maxAngle)&&(transform.eulerAngles.z<=360-(2*scale))){
          //Debug.Log(57);
          return transform.eulerAngles.z +(1*scale);
        }
      }
      return transform.eulerAngles.z;
    }
    private float addInclineHorizontal(float horizontalInput){


      //if ((horizontalInput == -1)&&((transform.eulerAngles.z < 360)||(transform.eulerAngles.z > 360 - maxAngle)||((transform.eulerAngles.z < 360)&&(transform.eulerAngles.z > maxAngle)))){
      if ((horizontalInput == -1)&&(((transform.eulerAngles.z > maxAngle)||(transform.eulerAngles.z < 360 - maxAngle))&&(!((transform.eulerAngles.z > maxAngle)&&(transform.eulerAngles.z < 360 - maxAngle)))))
      {
        return transform.eulerAngles.z + (-horizontalInput*scale);

      }
      else if ((horizontalInput == 1)&&((transform.eulerAngles.z < maxAngle)||(transform.eulerAngles.z > 360 - maxAngle))){
      //else if ((horizontalInput == 1)&&((transform.eulerAngles.z < maxAngle)||(transform.eulerAngles.z > 360 - maxAngle))){
        return transform.eulerAngles.z + (-horizontalInput*scale);
      }
      //decendNormalHorizontal(horizontalInput);
      return transform.eulerAngles.z;

    }
}
