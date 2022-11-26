using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CharacterControllig
{
    public class CursorController
    {
        private PlayerInputReferences plyerInput;
        private Camera mainCamera;

        public CursorController(PlayerInputReferences plyerInput, Camera cameraMain)
        {
            this.plyerInput = plyerInput;
            this.mainCamera = cameraMain;
        }

        public Vector3 GetCursorPosition()
        {
            RaycastHit hit;

            Ray ray = mainCamera.ScreenPointToRay((Vector3)plyerInput.CursorPos);

            if (Physics.Raycast(ray, out hit))
            {
                return hit.point;
            }

            return Vector3.zero;
        }
    }
}
