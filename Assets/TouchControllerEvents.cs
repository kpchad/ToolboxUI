using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OVRTouchSample
{
    public class TouchControllerEvents : MonoBehaviour
    {

        public GameObject toolbox;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // if left controller "A" is pressed
            if (OVRInput.Get(OVRInput.Button.Four) == true) {

                    //show tool assets
                    toolbox.SetActive(true);
                
            } else  {
                    //hide tool assets
                    toolbox.SetActive(false);
                }

            
        }
    }
}