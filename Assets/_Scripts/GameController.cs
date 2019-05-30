using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameController : MonoBehaviour
{
    public GameObject doorTrack, jumpTrack, playerPrefab, playerCamera, winTrigger;

    public int level;

    private float spaceLength = 15;
    private float doortrackLength = 23;
    private float jumpTrackLength = 76;

    // Start is called before the first frame update
    void Start()
    {
        //Depending which level it is, it spawn the according amount of tracks.
        switch (level)
        {
            case 1:
                SpawnLevel(10);
                break;
            case 2:
                SpawnLevel(25);
                break;
            case 3:
                SpawnLevel(50);
                break;
        }
    }

    
    void SpawnLevel (int trackCount)
    {
        //Referring to last track positon and length, and it checks the position length of every tracks it spawn before it spawns the next one. 
        //So that the next one can spawn accordingly with the right distance from the last one.
        Vector3 lastSpawnPosition = Vector3.zero;
        float lastTrackLength = 0;

        //Loops through the amount of tracks it needs for the lvl, so if it needs 20 tracks(trackCount), then this loop will run 20 times.
        for (int i = 0; i < trackCount; i++)
        {
            //Finds a random one of two different tracks to spawn
            int random = Random.Range(0, 2);

            //if the random number is 0, then it will spawn a door track.
            if (random == 0)
            {
                //If this is the first iteration in the loop, spawn it at position zero
                if (i == 0)
                {
                    //Spawns the track at position zero(0,0,0)
                    Instantiate(doorTrack, Vector3.zero, Quaternion.identity);

                    //Set the last track length variable to the length of the door track.
                    lastTrackLength = doortrackLength;

                    //instantiate the player and the camera at location (0, 1, -10). This is done to fit the length/ position of the track.
                    Instantiate(playerPrefab, new Vector3(0, 1, -10), Quaternion.identity);
                    Instantiate(playerCamera, new Vector3(0, 1, -10), Quaternion.identity);
                }
                else
                {
                    //Spawn the track based on the position and the length of the last track and also adds some space between them.
                    Instantiate(doorTrack, lastSpawnPosition + new Vector3(0, 0, (lastTrackLength / 2) + (doortrackLength / 2) + spaceLength), Quaternion.identity);

                    //Set the last spawn position to what is being spawned here.
                    lastSpawnPosition += new Vector3(0, 0, (lastTrackLength / 2) + (doortrackLength / 2) + spaceLength);

                    //Set the last track length variable to the length of the door track.
                    lastTrackLength = doortrackLength;
                }
            }
            else //if the random number is not 0, then it will spawn a jump track.
            {
                //If this is the first iteration in the loop, spawn it at position zero
                if (i == 0)
                {
                    //Spawns the track at position zero(0,0,0)
                    Instantiate(jumpTrack, Vector3.zero, Quaternion.identity);

                    //Set the last track length variable to the length of the jump track.
                    lastTrackLength = jumpTrackLength;

                    //instantiate the player and the camera at location (0, 1, -35). This is done to fit the length/ position of the track.
                    Instantiate(playerPrefab, new Vector3(0, 1, -35), Quaternion.identity);
                    Instantiate(playerCamera, new Vector3(0, 1, -35), Quaternion.identity);
                }
                else
                {
                    //Spawn the track based on the position and the length of the last track and also adds some space between them.
                    Instantiate(jumpTrack, lastSpawnPosition + new Vector3(0, 0, (lastTrackLength / 2) + (jumpTrackLength / 2) + spaceLength), Quaternion.identity);

                    //Set the last spawn position to what is being spawned here.
                    lastSpawnPosition += new Vector3(0, 0, (lastTrackLength / 2) + (jumpTrackLength / 2) + spaceLength);
                    //Set the last track length variable to the length of the jump track.
                    lastTrackLength = jumpTrackLength;
                }
            }
        }
        //Spawn the win trigger. At the end of the last track.
        Instantiate(winTrigger, lastSpawnPosition + new Vector3(0, 0, (lastTrackLength / 2) - 3), Quaternion.identity);
    }
}
