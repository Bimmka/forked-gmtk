using UnityEngine;

namespace Code.Gameplay.Features.Stalls.Services
{
    public interface IStallService
    {
        void Registry(int index, GameEntity stall);
        void Unregistry(int index);
        void Clear();
        Vector3 GetRandomPositionInStall(int index);
        int GetStallIndex(Vector2 worldPosition);
        Vector3 GetRandomPositionInStall(int index, Vector3 at, float maxGap);
        int GetNearestValidStallIndexFromPosition(Vector3 position);
        GameEntity GetStallEntityByIndex(int index);
        GameEntity GetStallEntityByPosition(Vector3 worldPosition);
        int GetNonSunkenStallIndex(Vector2 worldPosition);
    }
}