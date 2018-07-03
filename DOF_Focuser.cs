using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class DOF_Focuser : MonoBehaviour
{

	public PostProcessVolume PostProcessingVolume;

    public enum FocusType
    {
        Transform,
        View
    }
    [SerializeField]
    private FocusType _focusMode;
    public FocusType FocusMode
    {
        get { return _focusMode; }
        set { _focusMode = value; }
    }


    [SerializeField]
    private Transform _target;
    public Transform Target
    {
        get { return _target; }
        set { _target = value; }
    }

    [SerializeField]
    private Camera _camera;
    public Camera Camera
    {
        get { return _camera; }
        set { _camera = value; }
    }

    [SerializeField]
    private float _speed;
    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

	[SerializeField]
    private bool _debug;
    public bool Debugging
    {
        get { return _debug; }
        set { _debug = value; }
    }


	//public LayerMask hitMask;

    
    internal DepthOfField ppfx_dof;
    internal float _defaultFocusDistance = 10.0f;

    // Use this for initialization
    private void Start() {
        PostProcessingVolume.profile.TryGetSettings(out ppfx_dof);
        ppfx_dof.enabled.Override(true);
    }

    // Update is called once per frame
    private float _velocity;
    private void Update()
    {
        var d1 = ppfx_dof.focusDistance;
        var dt = Time.deltaTime;

        if (FocusMode == FocusType.Transform)
        {
            if (Target == null) return;
            var d2 = Vector3.Dot(Target.position - Camera.transform.position, Camera.transform.forward);
			var n1 = _velocity - (d1 - d2) * Speed * Speed * dt;
			var n2 = 1 + Speed * dt;
			_velocity = n1 / (n2 * n2);
			var d = d1 + _velocity * dt;

            ppfx_dof.focusDistance.Override(d);

			if(Debugging)
				Debug.DrawLine(Camera.transform.position, Target.transform.position, Color.blue);
        }

        else if (FocusMode == FocusType.View)
        {
            RaycastHit hit;
            Ray ray = Camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
            if (Physics.Raycast(ray, out hit))
            {
                var d2 = Vector3.Dot(hit.point - Camera.transform.position, Camera.transform.forward);
                var n1 = _velocity - (d1 - d2) * Speed * Speed * dt;
                var n2 = 1 + Speed * dt;
                _velocity = n1 / (n2 * n2);
                var d = d1 + _velocity * dt;

                ppfx_dof.focusDistance.Override(d);

				if(Debugging)
					Debug.DrawRay(Camera.transform.position, transform.forward * _defaultFocusDistance, Color.blue);
            }
            else
            {
                ppfx_dof.focusDistance.Override(_defaultFocusDistance);
            }
        }
    }
}

