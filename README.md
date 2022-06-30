# HRtest
> 정리
- 이동의 세가지 방법 : Transform, AddForce, Vector의 MovePosition
 > MovetoWard : Transform이 방향대로 쭉 이동하고 MovetoWard는 원하는 위치를 지정하여 이동한다.
 >> Vector3의 값을 가져오면 (GameObject.transform.position.x, GameObject.transform.position.y, GameObject.transform.position.z )로 구성됨
 새 백터 함수에 가져올 값만 넣어서 가져온다. - 공중부양 방지
- 반전 세가지 : Rotation, Animation, SpriteRenderer Flip
- 안개 : Particle System >> 회전 후 시간 크기 색상 변경
- 유니티 내에서 애니메이션 생성 시 Debug 탭에서 Legacy 체크, Normal 탭에서 Once로 변경
- 조명( 점등, Intensity 조절 ) : 파티클에 Texture Sheet Animation, Renderer, LifeTime 설정 >> 애니메이션, 스크립트 코루틴 사용
- 문 열기
1. 문 흰지 애니메이션 89도. 문에 애니메이터 제거 후 애니메이션 등록
2. InputManager 전체 크기 +1 이름과 상호작용 키 등록
3. Laycast 오브젝트 간 거리를 Static 변수에 담기
4. 문 트리거 오브젝트로 OnMouseOver, OnMouseExit 사용
- 오브젝트 설명 UI : OnMouseOver, Exit SetActive
- 페이드인 : UI > RawImage > 검정색 Alpha값 애니메이션 적용 > 스크립트에서 끄기 > 플레이어 이동 컴포넌트 Enabled 끄기 > 코루틴 시작 > 코루틴 종료 전까지 텍스트 진행
- 트리거 : 큐브 렌더러 끄고 콜라이더 트리거 ON > 스크립트 온 트리거 플레이어 컴포넌트 끄기 & 코루틴 텍스트 진행 >
- 아이템 획득 : 필드/실제 두가지 오브젝트를 두고 트리거 콜라이더에서 상호작용 시 SetActive ON/Off 동시 적용
- 점프스퀘어A : 트리거에 BGM, 오브젝트, 애니메이션 실행
- 원거리 공격 : Raycast로 SendMessage 사용. 받은 오브젝트에서 SendMessage의 값을 적용시킴
- 오브젝트 온/오프 체크 : gameObject.activeSelf == true
- OnCollision > Collision, OnTrigger > Collider, 충돌체크 Collision/Collider.GameObject == 비교 오브젝트
- 추노 : Vector3.MoveTowards(쫓아갈 대상, 쫓을 대상(Vector3(x, y, z), 속도) 
 > 플레이어 주변 콜라이더와 충돌 시 속도 0, 코루틴 사용
- 애니메이션 : animator.Play("name");, animator.CrossFade("name", 변한시간f);


- ?
1. 애니메이터 삭제 후 애니메이션 등록
2. Collision, Trigger 와 Laycast
3. namespace UnityStandardAssets.Characters.FirstPerson
