using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviormentScript : MonoBehaviour
{
    public List<LightningStrike> LightningStrikeList;
    public Transform grandparent;
    public GameObject parent;
    //public float time;
    public float delay;


    // Start is called before the first frame update


    // Update is called once per frame
    void Start()
    {
        StartCoroutine(SpawnLightningEnum(LightningStrikeList[Random.Range(0, (LightningStrikeList.Count-1))].Lightning));
    }
    IEnumerator SpawnLightningEnum(GameObject lightning)
    {
      yield return new WaitForSeconds(delay);
      // Quaternion newQuaternion = new Quaternion();

      GameObject newEnemy = Instantiate(lightning,grandparent,false);
      //GameObject newEnemy = Instantiate(lightning, new Vector3(0,10,0), newQuaternion);
      newEnemy.transform.SetParent(parent.transform);
      newEnemy.transform.position = new Vector3(0,0,0);
      newEnemy.transform.localScale = new Vector3(0.1f,0.05f,0.1f);
      newEnemy.transform.Rotate (0f, 0f, Random.Range(-90, 90));


      StartCoroutine(SpawnLightningEnum(LightningStrikeList[Random.Range(0, (LightningStrikeList.Count-1))].Lightning));
    }
    //Random.Range(-90, 90)
}

[System.Serializable]

public class LightningStrike{

  public GameObject Lightning;



}
