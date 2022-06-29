# HRtest
> 정리
- 이동의 세가지 방법 : Transform, AddForce, Vector의 MovePosition
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
- 페이드인


- ?
1. 애니메이터 삭제 후 애니메이션 등록
2. Collision, Trigger 와 Laycast
