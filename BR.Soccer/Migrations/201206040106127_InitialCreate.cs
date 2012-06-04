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
                "dbo.GroupTeams",
                c => new
                    {
                        GroupTeamId = c.Int(nullable: false, identity: true),
                        Team_TeamId = c.Int(),
                        Player1_PlayerId = c.Int(),
                        Player2_PlayerId = c.Int(),
                        Group_GroupId = c.Int(),
                    })
                .PrimaryKey(t => t.GroupTeamId)
                .ForeignKey("dbo.Teams", t => t.Team_TeamId)
                .ForeignKey("dbo.Players", t => t.Player1_PlayerId)
                .ForeignKey("dbo.Players", t => t.Player2_PlayerId)
                .ForeignKey("dbo.Groups", t => t.Group_GroupId)
                .Index(t => t.Team_TeamId)
                .Index(t => t.Player1_PlayerId)
                .Index(t => t.Player2_PlayerId)
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
                    })
                .PrimaryKey(t => t.PlayerId);
            
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
                        Team1_TeamId = c.Int(),
                        Team1Player1_PlayerId = c.Int(),
                        Team1Player2_PlayerId = c.Int(),
                        Team2_TeamId = c.Int(),
                        Team2Player1_PlayerId = c.Int(),
                        Team2Player2_PlayerId = c.Int(),
                        Stage_StageId = c.Int(),
                    })
                .PrimaryKey(t => t.GameId)
                .ForeignKey("dbo.Teams", t => t.Team1_TeamId)
                .ForeignKey("dbo.Players", t => t.Team1Player1_PlayerId)
                .ForeignKey("dbo.Players", t => t.Team1Player2_PlayerId)
                .ForeignKey("dbo.Teams", t => t.Team2_TeamId)
                .ForeignKey("dbo.Players", t => t.Team2Player1_PlayerId)
                .ForeignKey("dbo.Players", t => t.Team2Player2_PlayerId)
                .ForeignKey("dbo.Stages", t => t.Stage_StageId)
                .Index(t => t.Team1_TeamId)
                .Index(t => t.Team1Player1_PlayerId)
                .Index(t => t.Team1Player2_PlayerId)
                .Index(t => t.Team2_TeamId)
                .Index(t => t.Team2Player1_PlayerId)
                .Index(t => t.Team2Player2_PlayerId)
                .Index(t => t.Stage_StageId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Games", new[] { "Stage_StageId" });
            DropIndex("dbo.Games", new[] { "Team2Player2_PlayerId" });
            DropIndex("dbo.Games", new[] { "Team2Player1_PlayerId" });
            DropIndex("dbo.Games", new[] { "Team2_TeamId" });
            DropIndex("dbo.Games", new[] { "Team1Player2_PlayerId" });
            DropIndex("dbo.Games", new[] { "Team1Player1_PlayerId" });
            DropIndex("dbo.Games", new[] { "Team1_TeamId" });
            DropIndex("dbo.GroupTeams", new[] { "Group_GroupId" });
            DropIndex("dbo.GroupTeams", new[] { "Player2_PlayerId" });
            DropIndex("dbo.GroupTeams", new[] { "Player1_PlayerId" });
            DropIndex("dbo.GroupTeams", new[] { "Team_TeamId" });
            DropIndex("dbo.Groups", new[] { "Stage_StageId" });
            DropIndex("dbo.Stages", new[] { "Tournament_TournamentId" });
            DropForeignKey("dbo.Games", "Stage_StageId", "dbo.Stages");
            DropForeignKey("dbo.Games", "Team2Player2_PlayerId", "dbo.Players");
            DropForeignKey("dbo.Games", "Team2Player1_PlayerId", "dbo.Players");
            DropForeignKey("dbo.Games", "Team2_TeamId", "dbo.Teams");
            DropForeignKey("dbo.Games", "Team1Player2_PlayerId", "dbo.Players");
            DropForeignKey("dbo.Games", "Team1Player1_PlayerId", "dbo.Players");
            DropForeignKey("dbo.Games", "Team1_TeamId", "dbo.Teams");
            DropForeignKey("dbo.GroupTeams", "Group_GroupId", "dbo.Groups");
            DropForeignKey("dbo.GroupTeams", "Player2_PlayerId", "dbo.Players");
            DropForeignKey("dbo.GroupTeams", "Player1_PlayerId", "dbo.Players");
            DropForeignKey("dbo.GroupTeams", "Team_TeamId", "dbo.Teams");
            DropForeignKey("dbo.Groups", "Stage_StageId", "dbo.Stages");
            DropForeignKey("dbo.Stages", "Tournament_TournamentId", "dbo.Tournaments");
            DropTable("dbo.Games");
            DropTable("dbo.Players");
            DropTable("dbo.Teams");
            DropTable("dbo.GroupTeams");
            DropTable("dbo.Groups");
            DropTable("dbo.Stages");
            DropTable("dbo.Tournaments");
        }
    }
}
