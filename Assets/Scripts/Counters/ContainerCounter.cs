using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ContainerCounter : BaseCounter
{

    [SerializeField] private KitchenObjectSO kichenObjectSO;
    public event EventHandler OnPlayerGrabbedObject;

    public override void Interact(Player player)
    {
        if (!player.HasKitchenObject())
        {
            //Player is not carrying anything
            KitchenObject.SpawnKitchenObject(kichenObjectSO, player);
            OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
        }

    }
}
