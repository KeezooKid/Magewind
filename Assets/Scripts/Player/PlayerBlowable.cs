using System;
using UnityEngine;

public class PlayerBlowable : Blowable
{

    //Settings

    //References

    private PlayerParasol m_PlayerParasol;

    //Events

    //Public Fields

    //Private Fields

    //Initialization Methods

    protected override void GetReferences ()
    {
        m_BlowableRigidbody = GetComponent<Rigidbody>();
        m_PlayerParasol = GetComponent<PlayerParasol>();
    }

	//Play Methods

	//Public Methods

	//Private Methods

	protected override void UpdateWind()
    {
        // This is a hack because Unity's physics is retarded
        m_BlowableRigidbody.rotation = Quaternion.Euler(0, 0, 0);

        if (IsInWind() && m_PlayerParasol.IsParasolOpen)
        {
            m_BlowableRigidbody.AddForce(m_CurWindForce);
        }
    }

}