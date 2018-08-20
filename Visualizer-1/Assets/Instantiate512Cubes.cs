using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate512Cubes : MonoBehaviour {
    public GameObject _sampleCubesPrefab;
    GameObject[] _sampleCube = new GameObject[512];
    public float maxScale;

	// Use this for initialization
	void Start () {
		for(int i = 0; i<512; i++)
        {
            GameObject _instanceSampleCube = (GameObject)Instantiate(_sampleCubesPrefab);
            _instanceSampleCube.transform.position = this.transform.position;
            _instanceSampleCube.transform.parent = this.transform;
            _instanceSampleCube.name = "Sample cube" + i;
            this.transform.eulerAngles = new Vector3(0f, -0.703125f * i, 0f );
            _instanceSampleCube.transform.position = Vector3.forward*100;
            _sampleCube[i] = _instanceSampleCube;

        }
	}
	
	// Update is called once per frame
	void Update () {
		for(int i=0; i<512; i++)
        {
            if (_sampleCube != null)
            {
                _sampleCube[i].transform.localScale= new Vector3(10f, (AudioPeer._samples[i] * maxScale) + 2, 10f);
            }
        }
	}
}
