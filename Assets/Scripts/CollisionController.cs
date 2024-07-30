using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        SpriteRenderer collidedSpriteRender = other.gameObject.GetComponent<SpriteRenderer>();
        collidedSpriteRender.color = Color.blue;
    }
}
