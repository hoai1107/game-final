
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public AudioSource collisionSoundEffect;

    void OnCollisionEnter(Collision colInfo)
    {
        if (colInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            collisionSoundEffect.time = 0.6f;
            collisionSoundEffect.Play();
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
