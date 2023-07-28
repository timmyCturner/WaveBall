using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehavior : MonoBehaviour
{
    public float scale;
    public AnimationCurve curveZ;
    //public AnimationCurve curveXY;
    private Vector3 scaleChange;
    private float curr;
    private float curveDeltaTimeZ = 0.0f;
    //private float curveDeltaTimeXY = 0.0f;
    private float zscale = 0.0f;
    //private float xyscale = 0.0f;


    void Start(){
      curr = 0;
      scale = 0.002f;
      scaleChange = new Vector3(scale,scale,scale);
      Invoke("DestroyEnemy", 20f);
    }
    void Update()
    {

            curveDeltaTimeZ+= Time.deltaTime;
            zscale = curveZ.Evaluate(curveDeltaTimeZ);

            // curveDeltaTimeXY+= Time.deltaTime;
            // xyscale = curveXY.Evaluate(curveDeltaTimeXY);
            curr = this.transform.localScale.x*scale;







            curr = this.transform.localScale.x + this.transform.localScale.x*scale;
            scaleChange = new Vector3(curr,curr,zscale);



            //this.transform.localScale += scaleChange;





            this.transform.localScale = scaleChange;



    }
    public void DestroyEnemy()
    {

        Destroy(gameObject);
    }
}
