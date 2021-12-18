using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public GameObject HotBar;
    bool hotbarHidden;
    Animator h_Anim;
    private Vignette vignette = null;
    private PlayerMovement pMovement;
    private PlayerCamera pCamera;
    bool alreadyActive = false;
    float activeValue = 1;
    float nonActiveValue = 0.2f;

    [SerializeField]
    Volume volume;

    private void Start()
    {
        volume.sharedProfile.TryGet<Vignette>(out vignette);
        pMovement = GetComponent<PlayerMovement>();
        pCamera = FindObjectOfType<PlayerCamera>();
        h_Anim = HotBar.gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.C))
        {
            changeState();
        }
        */

        if (Input.GetKeyDown(KeyCode.B))
        {
            if (!hotbarHidden)
            {
                hotbarHidden = true;
                h_Anim.SetBool("Hidden", true);
            }
            else
            {
                hotbarHidden = false;
                h_Anim.SetBool("Hidden", false);
            }
        }
    }

    private void changeState()
    {
        if (!alreadyActive)
        {
            vignette.smoothness.SetValue(new NoInterpMinFloatParameter(activeValue, 0, true));
            pMovement.moveSpeed -= 1;
            pCamera.revealHidden();
            alreadyActive = true;
        }
        else
        {
            vignette.smoothness.SetValue(new NoInterpMinFloatParameter(nonActiveValue, 0, true));
            pMovement.moveSpeed += 1;
            pCamera.revealHidden();
            alreadyActive = false;
        }
    }
}