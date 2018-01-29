using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Complete
{

    public class DayNight : MonoBehaviour
    {
        public TankManager[] tankManagers;
        //public List<GameObject> gameObjects;
        public List<Transform> waypointsForAI;
        public GameObject tankPrefab;
        float coco;
        public Color32 color32 = new Color32(32, 27, 32, 53);
        public bool ColorOn = false;
		public Quaternion originalRotationValue;

        private AudioSource audioSource;
        public AudioClip anthem;

        void Start()
        {
			originalRotationValue = transform.rotation;
        }


        // Use this for initialization
        //	public class IfStatements : MonoBehaviour{



        // Update is called once per frame
        void Update()
        {

            RotationCheck();
            transform.Rotate(new Vector3(0.08f, 0f, 0f));
            if (ColorOn == false)
            {
                RenderSettings.ambientLight = color32;
            }
            else if (ColorOn == true)
            {
                RenderSettings.ambientLight = Color.red;
            }
        }


        void RotationCheck()
        {

            this.coco = transform.localEulerAngles.x;
            Debug.Log(this.coco);


			if (Math.Round(coco, 5) == 21.99551) 
            {

                for (int i = 0; i < tankManagers.Length; i++) {
                    tankManagers[i].m_Instance = Instantiate(tankPrefab, tankManagers[i].m_SpawnPoint.position, tankManagers[i].m_SpawnPoint.rotation) as GameObject;
                    tankManagers[i].m_PlayerNumber = i + 10;
                    tankManagers[i].SetupAI(waypointsForAI);
                }

                ColorOn = true;
                audioSource = GetComponent<AudioSource>();
                audioSource.clip = anthem;
                audioSource.Play();


                //foreach (GameObject obj in gameObjects)
                //{
                //    GameObject newTank = Instantiate(tank, obj.transform.position, Quaternion.identity) as GameObject;
                //    StateController controller = newTank.GetComponent<StateController>();

                //    controller.SetupAI(waypointsForAI);




                //}
            }
            if (Math.Round(coco, 4) == 318.7615)
            {
                ColorOn = false;
				transform.rotation = originalRotationValue;
				//this.transform.rotation.x = 53;
				//gameObject.transform.rotation = originalPos;
            }
        }
    }


    //}

}