using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public SpawnerSetting _spawnSetting;
    public SpawnerSetting _spawnSetting2;
    public SpawnerSetting _spawnSetting3;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnObject", 1.0f);
        Invoke("SpawnObject2", 1.0f);
        Invoke("SpawnObject3", 1.0f);
    }
    void SpawnObject()
    {
        GameObject obj1 = Instantiate(_spawnSetting.SpawnObject,new Vector3(_spawnSetting.X, _spawnSetting.Y, 
        _spawnSetting.Z),Quaternion.identity);

        obj1.gameObject.GetComponent<Renderer>().material.color = new Color (_spawnSetting.R,_spawnSetting.G,_spawnSetting.B,1);

        if(_spawnSetting.destroyTime >0){
            Destroy(obj1, _spawnSetting.destroyTime);
        }

        if(_spawnSetting.nextSpawnTime >0){
            Invoke("SpawnObject", _spawnSetting.nextSpawnTime);
        }
    }

    void SpawnObject2()
    {
        GameObject obj2 = Instantiate(_spawnSetting2.SpawnObject,new Vector3(_spawnSetting2.X, _spawnSetting2.Y, 
        _spawnSetting2.Z),Quaternion.identity);

        obj2.gameObject.GetComponent<Renderer>().material.color = new Color (_spawnSetting2.R,_spawnSetting2.G,_spawnSetting2.B,1);

        if(_spawnSetting2.destroyTime >0){
            Destroy(obj2, _spawnSetting2.destroyTime);
        }

        if(_spawnSetting2.nextSpawnTime >0){
            Invoke("SpawnObject2", _spawnSetting2.nextSpawnTime);
        }
    }
    void SpawnObject3()
    {
        GameObject obj3 = Instantiate(_spawnSetting3.SpawnObject,new Vector3(_spawnSetting3.X, _spawnSetting3.Y, 
        _spawnSetting3.Z),Quaternion.identity);

        obj3.gameObject.GetComponent<Renderer>().material.color = new Color (_spawnSetting3.R,_spawnSetting3.G,_spawnSetting3.B,1);

        if(_spawnSetting3.destroyTime >0){
            Destroy(obj3, _spawnSetting3.destroyTime);
        }

        if(_spawnSetting3.nextSpawnTime >0){
            Invoke("SpawnObject3", _spawnSetting3.nextSpawnTime);
        }
    }

}
