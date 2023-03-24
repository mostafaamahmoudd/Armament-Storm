using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvents : MonoBehaviour
{
    public PlayerMovement pMove;
   public void PlayerAttack()
    {
        Debug.Log("Player Attack");
        pMove.DoAttack();
    }
}
