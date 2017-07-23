CREATE PROCEDURE Get_Comments
	@StartDate datetime,
	@EndDate datetime
AS
	SELECT
		cmnt.Id,
		Content,
		Username,
		CreatedAt,
		ArticleId,
		StatusId,
		cmnt.ParentId,
		st.Title as StatusTitle
	FROM Comment cmnt
	JOIN Status st ON cmnt.StatusId = st.Id
	WHERE StatusId = 2 AND CreatedAt BETWEEN @StartDate AND @EndDate;
RETURN 0