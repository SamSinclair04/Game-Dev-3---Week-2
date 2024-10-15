using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.Guns
{
    public class Guns_Sniper : Guns_Parent
    {
        public override void GunSound()
        {
            //Randomise pitch between two values
            gunAudioSource.pitch = Random.Range(0.6f, 1.4f);
            //Plays sound once
            gunAudioSource.PlayOneShot(gunSound);
        }
    }
}
