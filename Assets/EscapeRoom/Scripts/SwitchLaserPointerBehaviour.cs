using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLaserPointerBehaviour : MonoBehaviour {

    [SerializeField]
    private LaserPointer laserPointer;
    [SerializeField]
    private LaserPointer.LaserBeamBehavior laserBeamBehavior;

    private void Start() {
        laserPointer.laserBeamBehavior = laserBeamBehavior;
    }
}
