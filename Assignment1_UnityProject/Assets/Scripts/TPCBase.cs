using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PGGE
{
    // The base class for all third-person camera controllers
    public abstract class TPCBase
    {
        protected Transform mCameraTransform;
        protected Transform mPlayerTransform;

        public Transform CameraTransform
        {
            get
            {
                return mCameraTransform;
            }
        }
        public Transform PlayerTransform
        {
            get
            {
                return mPlayerTransform;
            }
        }

        public TPCBase(Transform cameraTransform, Transform playerTransform)
        {
            mCameraTransform = cameraTransform;
            mPlayerTransform = playerTransform;
        }

        public void RepositionCamera()
        {
            //-------------------------------------------------------------------
            // Implement here.
            //-------------------------------------------------------------------
            //-------------------------------------------------------------------
            // Hints:
            //-------------------------------------------------------------------
            // check collision between camera and the player.
            // find the nearest collision point to the player
            // shift the camera position to the nearest intersected point
            //-------------------------------------------------------------------
            
            LayerMask mask = LayerMask.GetMask("Wall"); //get any objects within the wall layer
            float smoothing = 10f; //Smoothing value for the camera movement
            Vector3 cameraPos = mCameraTransform.position; //Set camera position for easier refrence
            Vector3 playerPos = mPlayerTransform.position; //Set player position for easier refrence
            if (Physics.Linecast(playerPos, cameraPos, out RaycastHit hit, mask)) //Check if there is collison between player and camera
            {
                mCameraTransform.position = Vector3.Lerp(cameraPos, (cameraPos.normalized * hit.distance), 
                    Time.deltaTime * smoothing);// Move the camera to the point where the ray impacts the wall
            }
            
        }

        public abstract void Update();
    }
}
