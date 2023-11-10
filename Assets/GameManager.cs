using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Animator _roundAnimator;

    public void RoundEnd()
    {
        _roundAnimator.Play("RoundEnd");
        RenderSettings.fog = false;
    }
    
}
