using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace myUtils
{

    public class Utils : MonoBehaviour
    {

        static Camera worldCamera = Camera.main;

        public static Vector3 GetMousePosition(LayerMask mouseHitLayer)
        {
            Vector3 position = Vector3.zero;
            Ray ray = worldCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, mouseHitLayer))
            {
                position = hit.point;
            }
            return position;
        }


    }


}
