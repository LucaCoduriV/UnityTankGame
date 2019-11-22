using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    private Rigidbody2D bulletBody;
    private float cannonSize = 2;

    // Start is called before the first frame update
    void Start()
    {
        bulletBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //angle de départ de la balle + l'objet depuis le quel la balle doit partir
    public void Departure(float speed, GameObject cannon)
    {
        float rotation = cannon.transform.eulerAngles.z;
        Vector2 vRotation = Tools.DegreeToVector2(rotation);

        //positionne la balle au bonne endroit pour qu'elle puisse sortir du cannon
        bulletBody.position = (Vector2)cannon.transform.position + vRotation * cannonSize;

        //donne une vitesse à la balle
        Vector2 vBullet = vRotation * speed;
        bulletBody.velocity = vBullet ;

        
    }

   

}
