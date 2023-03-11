using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GunTetris.Core 
{
    public class BlockSpawning : MonoBehaviour
    {
        [SerializeField] Transform ShootPos, ParentStore;
        [SerializeField] float blockSpawnDelay = 2.5f;
        [SerializeField] GameObject[] Blocks;
        int NextBlock;
        bool Spawned = true;
        bool Pressed = true;
        Coroutine BlockAuto;
        Coroutine ManuelPlace;
        Animator Myanimator;
        GameObject NewBlockSpawned;
        [SerializeField] Image BlockIncoming;
        
        

        private void Awake()
        {
            NextBlock = Random.Range(0, Blocks.Length);
        }

        private void Start()
        {
            Myanimator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.S) && Pressed)
            {
                ManuelPlace = StartCoroutine(BlockSpawningOBJInstant());
                Pressed = false;
            }
            else if (Spawned)
            {
                BlockAuto = StartCoroutine(BlockSpawningOBJ());
            }

            if (NextBlock==0) 
            {
                BlockIncoming.color= new Color32(0, 0, 255, 255);
            }
            else if(NextBlock == 1) 
            {
                BlockIncoming.color = new Color32(0, 255, 0, 255);
            }
            else if (NextBlock == 2)
            {
                BlockIncoming.color = new Color32(255, 140, 0, 255);
            }
            else if (NextBlock == 3)
            {
                BlockIncoming.color = new Color32(255, 0, 0, 255);
            }
            else if (NextBlock == 4)
            {
                BlockIncoming.color = new Color32(255, 255, 0, 255);
            }



        }

        IEnumerator BlockSpawningOBJ()
        {


            Spawned = false;
            var NumGen = Random.Range(0, Blocks.Length);
            yield return new WaitForSeconds(blockSpawnDelay);
            Myanimator.SetTrigger("Fire");
            NewBlockSpawned = Instantiate(Blocks[NextBlock], ShootPos.position, ShootPos.rotation, ParentStore) as GameObject;

            NextBlock = NumGen;
            Spawned = true;
            



        }
        IEnumerator BlockSpawningOBJInstant()
        {

            StopCoroutine(BlockAuto);
            Spawned = false;
            var NumGen = Random.Range(0, Blocks.Length);
            Myanimator.SetTrigger("Fire");
            NewBlockSpawned= Instantiate(Blocks[NextBlock], ShootPos.position, ShootPos.rotation, ParentStore)as GameObject;
           
            yield return new WaitForSeconds(0.1f);
            
            NextBlock = NumGen;
            StopCoroutine(ManuelPlace);

            Spawned = true;
            Pressed = true;



        }

       



    }

}