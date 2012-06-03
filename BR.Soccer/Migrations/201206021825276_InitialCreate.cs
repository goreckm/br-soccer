namespace BR.Soccer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        TournamentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StatusVal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TournamentId);
            
            CreateTable(
                "dbo.Stages",
                c => new
                    {
                        StageId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Order = c.Int(nullable: false),
                        TypeVal = c.Int(nullable: false),
                        StatusVal = c.Int(nullable: false),
                        Tournament_TournamentId = c.Int(),
                    })
                .PrimaryKey(t => t.StageId)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_TournamentId)
                .Index(t => t.Tournament_TournamentId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Stage_StageId = c.Int(),
                    })
                .PrimaryKey(t => t.GroupId)
                .ForeignKey("dbo.Stages", t => t.Stage_StageId)
                .Index(t => t.Stage_StageId);
            
            CreateTable(
                "dbo.MatchTeams",
                c => new
                    {
                        MatchTeamId = c.Int(nullable: false, identity: true),
                        Team_TeamId = c.Int(),
                        Group_GroupId = c.Int(),
                    })
                .PrimaryKey(t => t.MatchTeamId)
                .ForeignKey("dbo.Teams", t => t.Team_TeamId)
                .ForeignKey("dbo.Groups", t => t.Group_GroupId)
                .Index(t => t.Team_TeamId)
                .Index(t => t.Group_GroupId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TeamId);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MatchTeam_MatchTeamId = c.Int(),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.MatchTeams", t => t.MatchTeam_MatchTeamId)
                .Index(t => t.MatchTeam_MatchTeamId);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        Team1Score = c.Int(nullable: false),
                        Team1ScorePen = c.Int(nullable: false),
                        Team2Score = c.Int(nullable: false),
                        Team2ScorePen = c.Int(nullable: false),
                        IsOT = c.Boolean(nullable: false),
                        StatusVal = c.Int(nullable: false),
                        Team1_MatchTeamId = c.Int(),
                        Team2_MatchTeamId = c.Int(),
                        Stage_StageId = c.Int(),
                    })
                .PrimaryKey(t => t.GameId)
                .ForeignKey("dbo.MatchTeams", t => t.Team1_MatchTeamId)
                .ForeignKey("dbo.MatchTeams", t => t.Team2_MatchTeamId)
                .ForeignKey("dbo.Stages", t => t.Stage_StageId)
                .Index(t => t.Team1_MatchTeamId)
                .Index(t => t.Team2_MatchTeamId)
                .Index(t => t.Stage_StageId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Games", new[] { "Stage_StageId" });
            DropIndex("dbo.Games", new[] { "Team2_MatchTeamId" });
            DropIndex("dbo.Games", new[] { "Team1_MatchTeamId" });
            DropIndex("dbo.Players", new[] { "MatchTeam_MatchTeamId" });
            DropIndex("dbo.MatchTeams", new[] { "Group_GroupId" });
            DropIndex("dbo.MatchTeams", new[] { "Team_TeamId" });
            DropIndex("dbo.Groups", new[] { "Stage_StageId" });
            DropIndex("dbo.Stages", new[] { "Tournament_TournamentId" });
            DropForeignKey("dbo.Games", "Stage_StageId", "dbo.Stages");
            DropForeignKey("dbo.Games", "Team2_MatchTeamId", "dbo.MatchTeams");
            DropForeignKey("dbo.Games", "Team1_MatchTeamId", "dbo.MatchTeams");
            DropForeignKey("dbo.Players", "MatchTeam_MatchTeamId", "dbo.MatchTeams");
            DropForeignKey("dbo.MatchTeams", "Group_GroupId", "dbo.Groups");
            DropForeignKey("dbo.MatchTeams", "Team_TeamId", "dbo.Teams");
            DropForeignKey("dbo.Groups", "Stage_StageId", "dbo.Stages");
            DropForeignKey("dbo.Stages", "Tournament_TournamentId", "dbo.Tournaments");
            DropTable("dbo.Games");
            DropTable("dbo.Players");
            DropTable("dbo.Teams");
            DropTable("dbo.MatchTeams");
            DropTable("dbo.Groups");
            DropTable("dbo.Stages");
            DropTable("dbo.Tournaments");
        }
    }
}
