using UnityEngine;

public class T : MonoBehaviour
{
    [Header("動畫控制器")]
    public Animator animatorControl;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="HeadCollider"&& game.haveKey)
        {
            animatorControl.SetBool("character_nearby", true);
        }
    }
}
