using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInterractableTwoAttach : XRGrabInteractable
{
    public Transform LeftattachTransform;
    public Transform RightattachTransform;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.CompareTag("Left Hand"))
        {
            attachTransform = LeftattachTransform;
        } else if (args.interactorObject.transform.CompareTag("Right Hand"))
        {
            attachTransform = RightattachTransform;
        }

        base.OnSelectEntered(args);
    }
}
