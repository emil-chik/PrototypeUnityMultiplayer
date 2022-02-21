using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class OwnershipTransferGameObject : MonoBehaviourPun , IPunOwnershipCallbacks
{
    private void Awake()
    {
        PhotonNetwork.AddCallbackTarget(this);
    }

    private void OnDestroy()
    {
        PhotonNetwork.RemoveCallbackTarget(this);
    }

    public void OnOwnershipRequest(PhotonView targetView, Player requestingPlayer)
    {
        if (targetView != base.photonView)
            return;

        base.photonView.TransferOwnership(requestingPlayer);
    }

    public void OnOwnershipTransfered(PhotonView targetView, Player previousOwner)
    {
        if (targetView != base.photonView)
            return;
    }

    public void OnOwnershipTransferFailed(PhotonView targetView, Player senderOfFailedRequest)
    {
        if (targetView != base.photonView)
            return;
    }

    public void RequestOwnerShit()
    {
        base.photonView.RequestOwnership();
    }
}
