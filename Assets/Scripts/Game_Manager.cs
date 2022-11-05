using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    [SerializeField] Chr_Control playerControllScpt;
    [SerializeField] Play_Movement playerMoveScpt;

    [SerializeField] BoxCollider2D playerBox;
    [SerializeField] CircleCollider2D playerCir;
    [SerializeField] Rigidbody2D playerRigid;
    [SerializeField] Vector2 DeathForce;

    public void GameOver()
    {
        playerControllScpt.enabled = false;
        playerMoveScpt.enabled = false;

        playerBox.isTrigger = true;
        playerCir.isTrigger = true;

        playerRigid.AddForce(DeathForce, ForceMode2D.Impulse);
    }
}