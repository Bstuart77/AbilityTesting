using System;
using System.Collections;
using System.Collections.Generic;
using UdpKit;
using UnityEngine;

public class Menu : Bolt.GlobalEventListener
{
    ///HOST
    public void startServer()
    {
        BoltLauncher.StartServer();
    }
    //JOINING GAME
    public void startClient()
    {
        BoltLauncher.StartClient();
    }

    public override void BoltStartDone()
    {
        if (BoltNetwork.IsServer)
        {
            string matchName = "Testing";
            BoltNetwork.SetServerInfo(matchName, null);
            BoltNetwork.LoadScene("Game");
        }
    }
    public override void SessionListUpdated(Map<Guid, UdpSession> sessionList)
    {
        foreach(var session in sessionList)
        {
            UdpSession photonSession = session.Value as UdpSession;

            if(photonSession.Source == UdpSessionSource.Photon)
            {
                BoltNetwork.Connect(photonSession);
            }
        }
    }
}
