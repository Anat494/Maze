using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
namespace Assets.Scripts
{
[RequireComponent(typeof(NavMeshAgent))]
public class AIFollow : MonoBehaviour
{
[SerializeField] private Transform targetDestination;
private NavMeshAgent _agent;
// Use this for initialization
void Start()
{
_agent ??= GetComponent<NavMeshAgent>();
}
// Update is called once per frame
void Update()
{
if (_agent != null && targetDestination != null)
{
_agent.SetDestination(targetDestination.position);
}
}
}
}