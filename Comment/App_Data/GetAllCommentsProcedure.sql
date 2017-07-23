CREATE PROCEDURE Get_All_Comments
AS
	SELECT 
		cmnt.*,
		st.Title as StatusTitle
		FROM Comment cmnt
	JOIN Status st ON cmnt.StatusId = st.Id;
RETURN 0
