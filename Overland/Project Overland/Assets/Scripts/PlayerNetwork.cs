using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using Unity.Netcode;

public class PlayerNetwork : NetworkBehaviour
{
    private NetworkVariable<MyCustomData> randomNumber = new NetworkVariable<MyCustomData>(
        new MyCustomData
        {
            //_int = 56,
            //_bool = true,
        }, NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);


    public struct MyCustomData : INetworkSerializable
    {
        //public int _int;
        //public bool _bool;
        //public FixedString128Bytes _message;

        public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T: IReaderWriter
        {
            //serializer.SerializeValue(ref _int);
            //serializer.SerializeValue(ref _bool);
            //serializer.SerializeValue(ref _message);
        }
    }
    public override void OnNetworkSpawn()
    {
        //randomNumber.OnValueChanged += (MyCustomData previousValue, MyCustomData newValue) => {
        //    Debug.Log(OwnerClientId + "; "+ newValue._int + "; " + newValue._bool);
        //};
    }
    private void Update()
    {
        if (!IsOwner) return;

        Vector3 moveDir = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.Z)) moveDir.z = +2f;
        if (Input.GetKey(KeyCode.S)) moveDir.z = -2f;
        if (Input.GetKey(KeyCode.Q)) moveDir.x = -2f;
        if (Input.GetKey(KeyCode.D)) moveDir.x = +2f;

        float moveSpeed = 3f;
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }
}
