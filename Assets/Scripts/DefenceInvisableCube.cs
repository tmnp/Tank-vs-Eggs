using UnityEngine;

public class DefenceInvisableCube : MonoBehaviour
{
    public GameObject invisableWall;


    public void OnDestroy()
    {
        Instantiate(invisableWall, transform.position, transform.rotation);
    }

}