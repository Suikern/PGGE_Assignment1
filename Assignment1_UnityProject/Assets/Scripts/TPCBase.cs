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
            LayerMask mask = LayerMask.GetMask("Wall");
            float smoothing = 10f;
            Vector3 cameraPos = mCameraTransform.position;
            Vector3 distance = (mPlayerTransform.position - mCameraTransform.position);
            Vector3 direction = distance.normalized;
            RaycastHit hit;
            while ( )
            if (Physics.SphereCast(cameraPos, 0.2f, direction, out hit, Mathf.Infinity, mask)){
                mCameraTransform.Translate((hit.point + direction) * smoothing * Time.deltaTime);
                Debug.Log("AAAAAA");
                
            }
        }

        public abstract void Update();
    }
}
