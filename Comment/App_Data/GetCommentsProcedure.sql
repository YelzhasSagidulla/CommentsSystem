CREATE PROCEDURE Get_Comments
	@StartDate date,
	@EndDate date
AS
	SELECT
		cmnt.Id,
		cmnt.Content,
		cmnt.Username,
		cmnt.CreatedAt,
		artcl.Id as ArticleId,
		artcl.Title as ArticleTitle,
		artcl.Description as ArticleDescription,
		st.Id as StatusId,
		st.Title as StatusTitle
	FROM Comment cmnt
	JOIN Article artcl ON artcl.Id = cmnt.ArticleId
	JOIN Status st ON st.Id = cmnt.StatusId
	WHERE cmnt.CreatedAt BETWEEN @StartDate AND @EndDate
RETURN 0
